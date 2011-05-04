--[[
	@desc	
	@author	Hejiabin
	@date	2011.05.02
--]]


-- Create a empty map
function CreateMap( width, height )
	local _map = {}

	_map._width = width
	_map._height = height

	_map._tileCount = 0

	return _map
end


-- return map width & height
function GetMapSize( map )
	return map._width, map._height
end


-- return map tile count
function GetTileCount( map )
	return map._tileCount
end


-- Add a tile to the map
function AddTile( map, tile )
	map._tileCount = map._tileCount + 1
	map[map._tileCount] = tile
end


-- Create a tile of map
function CreateTile( img, wid, hei, x, y )
	local _tile = {}

	_tile._image = img
	_tile._width = wid
	_tile._height = hei
	_tile._x = x
	_tile._y = y

	_tile._physicBlockCount = 0

	return _tile
end


-- Add a physic block to the tile
function AddPhysicBlock( tile, physicBlock )
	tile._physicBlockCount = tile._physicBlockCount + 1
	tile[tile._physicBlockCount] = physicBlock
end


-- Load the map from file
function LoadMap( filePath )
	local path = system.pathForFile( filePath, system.ResourceDirectory )
	local file = io.open( path, "r" )
	
	local _map

	if file then

		print( "[Read the map info]" )

		local _tileCnt = file:read( "*n" )

		-- find the size flag
		repeat
			_flag = file:read( "*l" )
		until _flag == "[size]"

		-- read the map width & height
		_mapWid = file:read( "*n" )
		file:read( "*l" )
		_mapHei = file:read( "*n" )
		file:read( "*l" )

		-- create the map
		_map = CreateMap( _mapWid, _mapHei )

		-- read the tile info of the map
		for i = 1, _tileCnt do

			-- fine the tile flag
			repeat
				_flag = file:read( "*l" )
			until _flag == "[tile]"

			-- read the tile info
			_img = file:read( "*l" )
			_wid = file:read( "*n" )
			_hei = file:read( "*n" )
			file:read( "*l" )
			_x = file:read( "*n" )
			_y = file:read( "*n" )
			file:read( "*l" )

			-- create a tile
			_tile = CreateTile( _img, _wid, _hei, _x, _y )

			-- read the physic block
			_physicBlockCnt = file:read( "*n" )
			file:read( "*l" )

			-- add physic block to the tile
			for j = 1, _physicBlockCnt do
				_pointCnt = file:read( "*n" )
				
				_physicBlock = {}
				for k = 1, _pointCnt*2 do
					_physicBlock[k] = file:read( "*n" )
				end

				file:read( "*l" )

				AddPhysicBlock( _tile, _physicBlock )
			end

			-- add tile to the map
			AddTile( _map, _tile )
		end

		io.close( file )
	end

	return _map
end


--[Debug] Print the map data
function PrintMap( map )
	print( "[Map Size]: ", map._width, "x", map._height )

	local cnt = map._tileCount

	for i = 1, cnt do
		tile = map[i]
		print( "[Tile]: ", tile._image )
		print( "[size]: ", tile._width, tile._height, tile._x, tile._y )
		phyCnt = tile._physicBlockCount

		for j = 1, phyCnt do
			for k in ipairs( tile[j] ) do
				print( tile[j][k] )
			end
			print( "" )
		end

		print( "" )
	end
end
