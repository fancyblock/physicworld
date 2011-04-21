--[[
	@desc
	@author	Hejiabin
	@date	2011.04.09
--]]


require "RollScene"

--for test
local rec = display.newRect( 0, 0, 480, 320 )
rec:setFillColor( 40, 8, 70 )

display.setStatusBar( display.HiddenStatusBar )

-- Create the roll scene
CreateScene()

GenerateRandomScene()

local posx = 0

-- frame function
local function _enterFrame( event )
	
	FlushScene()

	MoveCamera( posx, 0 )
	posx = posx + 3 

	--[[
		Unfinished
	--]]
end

Runtime:addEventListener( "enterFrame", _enterFrame )

