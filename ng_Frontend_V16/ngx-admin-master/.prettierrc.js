module.exports = {
  // 箭頭函數只有一個參數的時候可以忽略括號
  arrowParens: "avoid",
  // 括號內部不要出現空格
  bracketSpacing: true,
  // 行結束符號使用 Unix 格式
  endOfLine: "lf",
  // true: 放在最後一行而不是新行
  bracketSameLine: false,
  // 行寬
  printWidth: 100,
  // 換行方式
  proseWrap: "preserve",
  // 分號
  semi: false,
  // 使用單引號
  singleQuote: true,
  // 縮排
  tabWidth: 2,
  // 使用 tab 縮排
  useTabs: false,
  // 後置逗號，多行物件、陣列在最後一行增加逗號
  trailingComma: "es5",
  parser: "typescript",
};
