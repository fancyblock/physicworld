--[[
	@desc
	@author	Hejiabin
	@date	2011.05.07
--]]


require "Map/Quadtree"

local _map = LoadMap( "lvTest.map" ) --CreateMap( 2000, 800 )

PrintMap( _map )


function _onFrame( event )
	print "."
end

Runtime:addEventListener( "enterFrame", _onFrame )
