--[[
	@desc	
	@author	Hejiabin
	@date	2011.4.11
--]]

local physics = require( "PhysicSystem" )

local _scene = nil

local _curCameraX = 0
local _curCameraY = 0

local _sceneObj = nil
local _sceneObjCnt = 0

local _redraw = nil
local _star = nil

-- Create the scene
function CreateScene( parent )
	print( "[RoolScene Created]" )

	local scene = display.newGroup()
	
	-- link the scene to the parent
	if parent ~= nil then
		parent:insert( scene )
	end

	_sceneObj = {}
	_redraw = false

	_scene = scene

	-- initial physic
	physics.InitialPhysic()
	physics.DrawMode( 1 )
end


-- Add Character
function AddCharacter()
	_star = display.newImage( _scene, "ui_star.png" )
	_star.x = 20
	_star.y = 250

	_star.physicProperty = { radius = 18 }
	physics.AddObj( _star )
	_star:applyForce( 1, 0, _star.x, _star.y )
end


--
function CharacterPos()
	return _star.x
end


-- Add Object
function AddBlock( block )
	
	_sceneObjCnt = _sceneObjCnt + 1
	_sceneObj[_sceneObjCnt] = block
	
	_redraw = true
end


-- Add Line
function AddBouncLine( x1, y1, x2, y2 )
	
	local offsetX = x2 - x1
	local offsetY = y2 - y1

	local line = display.newLine( _scene, 0, 0, offsetX, offsetY )
	line:setColor( 240, 15, 30 )
	line.width = 2

	line.xOrigin = 0
	line.yOrigin = 0

	line.x = _curCameraX + x1
	line.y = _curCameraY + y1

	--bounce calculator
	local bou = math.sqrt( ( x2 - x1 ) * ( x2 - x1 ) + ( y2 - y1 ) * ( y2 - y1 ) )
	bou = 100 - bou
	bou = bou / 9
	if bou < 0 then
		bou = 0
	end

	line.physicProperty = { bounce = bou , shape = {0,0,offsetX,offsetY} }
	physics.AddBody( line )
	
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
		
		local spr

		spr = display.newImage( _scene, v.img )

		spr.xOrigin = 0
		spr.yOrigin = 0
		
		spr.x = v.xpos
		spr.y = v.ypos

		physics.AddBody( spr )
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

	local cnt = 50
	local startOffset = 0

	for i = 1, 4 do
		AddBlock{ displayType = "Image", img = "board.png", xpos = startOffset, ypos = 310 }
		startOffset = startOffset + 230
	end
	
	for i = 1, cnt do
		AddBlock{ displayType = "Image", img = "board.png", xpos = startOffset, ypos = 310 }
		startOffset = startOffset + 360 
	end
end


