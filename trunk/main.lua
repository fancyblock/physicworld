--[[
	@desc
	@author	Hejiabin
	@date	2011.04.09
--]]


require "RollScene"
local movieclip = require "movieclip"

-- hide the statusBar
display.setStatusBar( display.HiddenStatusBar )




-- create the display layer
local g_bg = display.newGroup()
local g_world = display.newGroup()
local g_ui = display.newGroup()

-- create the background
display.newImage( g_bg, "bg.png" )

-- Create the roll scene
CreateScene( g_world )

GenerateRandomScene()

FlushScene()

AddCharacter()

local function AddLine( x1, y1, x2, y2 )
	AddBouncLine( x1, y1, x2, y2 )
end

-- create touch bg
local g_touchPanel = display.newImage( g_ui, "touchBg.png" )
local g_drawLine
local function _onTouch( event )
	local typ = event.phase

	if typ == "began" then
		--
	elseif typ == "moved" then
		if g_drawLine ~= nil then
			g_drawLine:removeSelf()
		end
		
		g_drawLine = display.newLine( event.xStart, event.yStart, event.x, event.y )
		g_drawLine:setColor( 60, 150, 25 )
		g_drawLine.width = 3
	elseif typ == "ended" then
		if g_drawLine ~= nil then
			g_drawLine:removeSelf()
			g_drawLine = nil
			AddLine( event.xStart, event.yStart, event.x, event.y )
		end
		
	end
end

g_touchPanel:addEventListener( "touch", _onTouch )



local posx = 0

-- frame function
local function _enterFrame( event )
	
	local chaPosX = CharacterPos()
--	MoveCamera( posx, 0 )
	MoveCamera( chaPosX, 0 )
	posx = posx + 2.7

end

Runtime:addEventListener( "enterFrame", _enterFrame )

