--[[
	@desc	
	@author	Hejiabin
	@date	2011.4.16
--]]

print( "[Physic System]" )

local g_physic = require( "physics" )

local g_physicSys = {}

--
function g_physicSys.InitialPhysic()
	g_physic = require( "physics" )
	g_physic.start( true )
	g_physic.setGravity( 0, 10 )
	g_physic.setDrawMode( "hybrid" )	--"hybrid", "debug"
end


--
function g_physicSys.AddBody( body )
	if body.physicProperty == nil then
		g_physic.addBody( body, "static" )
	end

	g_physic.addBody( body, body.physicProperty )
end


--
function g_physicSys.CreateRandomBody()
	local body = display.newCircle( math.random( 320 ), 0, math.random( 10, 25 ) )
	body.physicProperty = {}

	return body
end


--
function g_physicSys.DrawMode( mode )
	if mode == 1 then
		g_physic.setDrawMode( "normal" )
	elseif mode == 2 then
		g_physic.setDrawMode( "hybrid" )
	else
		g_physic.setDrawMode( "debug" )
	end
end

return g_physicSys
