--[[
	@desc
	@author	Hejiabin
	@date	2011.04.09
--]]



-- physic system initial
require "PhysicSystem"

InitialPhysic()

AddBody( CreateRandomBody() )

-- g_physic.addBody( xx, { density = 1.0, friction = 5, bounce = 0.1, shape = {} } )


print( "test" )
