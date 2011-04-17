--[[
	@desc	
	@author	Hejiabin
	@date	2011.4.16
--]]


local g_physic = require( "physics" )


--
function InitialPhysic()
	g_physic = require( "physics" )
	g_physic.start( true )
	g_physic.setGravity( 0, 9.8 )
	g_physic.setDrawMode( "normal" )
end


--
function AddBody( body )
	if body.physicProperty == nil then
		return
	end

	g_physic.addBody( body, body.physicProperty )
end


--
function CreateRandomBody()
	local body = display.newCircle( 100, 100, 20 )
	body.physicProperty = { density = 1.0, friction = 5, bounce = 0.1, radius = 20 }

	return body
end

