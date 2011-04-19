--[[
	@desc
	@author	Hejiabin
	@date	2011.4.16
--]]


-- the state machine
local StateMachine = {}


-- public functions

-- create a machine
local function StateMachine.newMachine( name )
	--[unfinished]
end



-- callback when enter
local function Enter( tickTime )
	print( "[Enter Function] not implement" )
end

-- callback every frame
local function Frame( tickTime )
	print( "[Frame Function] not implement" )
end

-- callback when end
local function Leave( tickTime )
	print( "[Leave Function] not implement" )
end


StateMachine.Enter = Enter
StateMachine.Frame = Frame
StateMachine.Leave = Leave


return StateMachine
