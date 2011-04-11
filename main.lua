--[[
	@desc
	@author	Hejiabin
	@date	2011.04.09
--]]


metaList = {}

--add function
function metaList.__add( listA, listB )
	for i,d in ipairs( listA ) do
		print( i, d )
	end

	for i,d in ipairs( listB ) do
		print( i, d )
	end

	return "List Add!"
end

--tostring function
function metaList.__tostring( list )
	return "This is a table"
end

--index function
function metaList.__index( list, key )
	value = rawget( list, key )

	if value then
		return value
	end

	return "not exist"
end

--set index function
function metaList.__newindex( list, key, value )
	rawset( list, key, value )
end




list1 = { "Hejiabin", "xujia", ['t'] = "Hami" }
list2 = { "Hejiabin", sex = "male", ["age"] = 25 }


setmetatable( list1, metaList )

list1[3] = "Mixi"
--print( list1[1], list1[2], list1[3], list1[4] )


local appVar = "hjbTest"

print( _G["appVar"] )
