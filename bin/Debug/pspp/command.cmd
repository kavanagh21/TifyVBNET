SET FORMAT F30.14.
GET DATA /TYPE=TXT
   /FILE='C:\Users\kavan\Documents\TifyVBNET\TifyVBNET\TifyVBNET\bin\Debug\pspp\data.csv'
   /ARRANGEMENT=DELIMITED
   /DELIMITERS=','
   /FIRSTCASE=1
   /VARIABLES=sDev F6.4
sIntDen F14.1
sKurt F5.4
sMax F5
sMean F6.4
sQID F6.5
sSkew F10.9
sSumSq F8.5
sPixelR F10.5
quality F18.9.
REGRESSION /VARIABLES=sDev sIntDen sKurt sMax sMean sQID sSkew sSumSq sPixelR /STATISTICS coeff r /DEPENDENT quality.