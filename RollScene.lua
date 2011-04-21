--[[
	@desc	
	@author	Hejiabin
	@date	2011.4.11
--]]


local _scene = nil

local _curCameraX = 0
local _curCameraY = 0

local _sceneObj = nil
local _sceneObjCnt = 0

local _redraw = nil


-- Create the scene
function CreateScene( parent )
	print( "[RoolScene Created]" )

	local scene = display.newGroup()
	
	-- link the scene to the parent
	if parent ~= nil then
		parent.insert( scene )
	end

	_sceneObj = {}
	_redraw = false

	_scene = scene
end


-- Add Object
function AddBlock( block )
	
	_sceneObjCnt = _sceneObjCnt + 1
	_sceneObj[_sceneObjCnt] = block
	
	_redraw = true
end


-- Move the camera
function MoveCamera( xPos, yPos )
	_curCameraX = xPos
	_curCameraY = yPos

	_scene.x = -xPos
	_scene.y = -yPos
	
	--[[
		Unfinished
	--]]
end


-- Clean the scene ( only in display )
function CleanScene()
	local num = _scene.numChildren
	for i = num, 1, -1 do
		local child = _scene[i]
		child.removeSelf()
	end
end


-- Remove all the display object from the scene
function EmptyScene()
	CleanScene()

	_sceneObj = {}
	_sceneObjCnt = 0
end


-- Render all the display objects on the scene
function FlushScene()
	
	-- if don't need to redraw the scene, then return
	if _redraw == false then
		return
	end
	
	-- clean the scene first
	CleanScene()
	
	-- [temp]
	for i, v in ipairs( _sceneObj ) do
		local spr = display.newImage( _scene, v.img )
		spr.xOrigin = 0
		spr.yOrigin = 0
		
		spr.x = v.xpos
		spr.y = v.ypos
	end

	-- redraw the scene
	--[[
		Unfinished
	--]]

	_redraw = false
end


-- Create Random Scene
function GenerateRandomScene()
	print( "[Generate a Random Scene]" )

	local cnt = math.random( 10, 20 )
	local startOffset = 0
	
	for i = 1, cnt do
		AddBlock{ img = "buttonBlue.png", xpos = startOffset, ypos = math.random( 260, 310 ) }
		startOffset = startOffset + 360
	end
end


