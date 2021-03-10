namespace Library1

module QuickSortClass=
  let private partition (A : int[])( low:int)( high:int):int=
      let pivot = A.[high]
      let mutable i=low
      for j=low to high do
          if A.[j]<pivot then
              let temp=A.[i]
              A.[i]<-A.[j]
              A.[j]<-temp
              i<-i+1
      let temp=A.[i]
      A.[i]<-A.[high]
      A.[high]<-temp
      i
      
  let rec quicksort (A : int[], low:int, high:int):int[]=
      let mutable Array = A
      if low < high then
          let p = partition(Array)(low)(high)
          Array<-quicksort(Array,low,p-1)
          Array<-quicksort(Array,p+1,high)
      Array