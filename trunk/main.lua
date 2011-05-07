--[[
	@desc
	@author	Hejiabin
	@date	2011.05.07
--]]


require "Scene/Scene"


-- Load the map
local _map = LoadMap( "lvTest.map" )
PrintMap( _map )


-- Initial the scene
local _gameCanva = display.newGroup()
local _scene = CreateScene( _gameCanva, _map )

MoveCamera( _scene, 0, 0 )

UpdateScene( _scene )



function _onFrame( event )
end


Runtime:addEventListener( "enterFrame", _onFrame )

