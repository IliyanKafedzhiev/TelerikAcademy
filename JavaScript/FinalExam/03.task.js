console.log((function k(n) { n = parseInt(n); return (n == 0) ? 1 : (4 * n - 2) * k(n - 1) / (n + 1) })(7) / 2);
