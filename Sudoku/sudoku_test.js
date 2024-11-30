const validRow = (row) => {

  for(let i = 1; i <= 9; i++){
    if(!row.find( element => element == i)){
      return false;
    }
  }

  return true;
}

const validSolution = (sudoku) => {
  let rows = sudoku;
  
  for(let index = 0; index < 9; index++){

    let i = Math.floor(index / 3) * 3;
    let j = (index % 3) * 3;

    let cube = [
      ...sudoku[i].slice(j, j + 3),
      ...sudoku[i + 1].slice(j, j + 3), 
      ...sudoku[i + 2].slice(j, j + 3)];

    let column = sudoku.map(array => array[index]);

    if(!validRow(rows[index]) || !validRow(column) || !validRow(cube)){
      return false;
    }

  };

  return true;

}

export default validSolution;