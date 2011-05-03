--[[
	@desc	
	@author	Hejiabin
	@date	2011.05.02
--]]


--Create a empty map
function CreateMap( width, height )
	local _map = {}

	_map._width = width
	_map._height = height

	_map._tileCount = 0

	return _map
end


--Add a tile to the map
function AddTile( map, tile )
	map._tileCount = map._tileCount + 1
	map[map._tileCount] = tile
end


--Load the map from file
function LoadMap( filePath )
	local path = system.pathForFile( filePath, system.ResourceDirectory )
	local file = io.open( path, "r" )
	
	local _map

	if file then

		print( "[Read the map info]" )

		local _blockCnt = file:read( "*n" )

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
		for i = 1, _blockCnt do

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

			--
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
		print( "[Tile]: ", tile._pic )
	end
end
