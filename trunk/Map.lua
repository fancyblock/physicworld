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
	local path = system.pathForFile( filePath, system.DocumentsDirectory )
	local file = io.open( path, "r" )

	local _map

	if file then

		local _blockCnt = file:read( "*n" )


		-- file:read( "*n" )	file:read( "*l" )

		io.close( file )
	end
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
