function solve(w, h, W, H) {
    let s1 = W * H;
    let s2 = w * h;
    let s3 = Math.min(w, W) * Math.min(h, H);

    return s1 + s2 - s3;
}
