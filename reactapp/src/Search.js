function Search(){
    return (
      <>
      <input type="text"></input>
      <button type="submit">Trie Search</button>
      <button type="submit">SQL Search</button>
      </>
    );
}

function SelectedItems({ ingredients }) {
    return (
        <div>
            {ingredients.map(ing => {
                return <div key={ing}>{ing}</div>;
            })}
        </div>
    );
}