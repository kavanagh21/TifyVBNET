SET FORMAT F30.14.
GET DATA /TYPE=TXT
   /FILE='C:\Users\kavan\Documents\TifyVBNET\TifyVBNET\TifyVBNET\bin\Release\psppFolder\data.csv'
   /ARRANGEMENT=DELIMITED
   /DELIMITERS=','
   /FIRSTCASE=1
   /VARIABLES=sEnt F6.5
sIntDen F14.1
sKurt F5.4
sQID F6.5
sSkew F10.9
sSumSq F8.5
sUnique F5
quality F18.9.
REGRESSION /VARIABLES=sEnt sIntDen sKurt sQID sSkew sSumSq sUnique /STATISTICS coeff r /DEPENDENT quality.