function demo(input){
    let [x1,y1,x2,y2,x3,y3] = input.map(Number)

    let istanceBetweenTwoPoints = (x1,y1,x2,y2)=> Math.sqrt(Math.pow((x2-x1),2)+Math.pow((y2-y1),2))

    let distance123 = istanceBetweenTwoPoints(x1,y1,x2,y2)+istanceBetweenTwoPoints(x2,y2,x3,y3)
    let distance132 = istanceBetweenTwoPoints(x1,y1,x3,y3)+istanceBetweenTwoPoints(x2,y2,x3,y3)
    let distance213 = istanceBetweenTwoPoints(x1,y1,x2,y2)+istanceBetweenTwoPoints(x1,y1,x3,y3)

    let shorrt = Math.min(distance123,distance132,distance213)



    if(shorrt == distance123){
        console.log("1->2->3: "+shorrt)
    }else if(shorrt == distance132){
        console.log("1->3->2: "+shorrt)
    }else{
        console.log("2->1->3: "+shorrt)
    }
}