import React, { useState, useEffect } from "react";

const RightClickMenu = ({ x, y, onItemClick }) => {
  const handleClick = (action) => {
    onItemClick(action);
  };

  return (
    <div
      style={{
        position: "absolute",
        top: y,
        left: x,
        backgroundColor: "white",
        boxShadow: "0 2px 5px rgba(0, 0, 0, 0.15)",
        padding: "8px"
      }}
    >
      <div onClick={() => handleClick("Action 1")}>Action 1</div>
      <div onClick={() => handleClick("Action 2")}>Action 2</div>
      <div onClick={() => handleClick("Action 3")}>Action 3</div>
    </div>
  );
};

const App = () => {
  const [showMenu, setShowMenu] = useState(false);
  const [menuX, setMenuX] = useState(0);
  const [menuY, setMenuY] = useState(0);
  const [selectedAction, setSelectedAction] = useState("");

  const handleContextMenu = (e) => {
    e.preventDefault();

    setShowMenu(true);
    setMenuX(e.clientX);
    setMenuY(e.clientY);
  };

  const handleLeftClick = () => {
    setShowMenu(false);
  };

  const handleItemClick = (action) => {
    setSelectedAction(action);
  };

  useEffect(() => {
    window.addEventListener("contextmenu", handleContextMenu);
    window.addEventListener("click", handleLeftClick);
    return () => {
      window.removeEventListener("contextmenu", handleContextMenu);
      window.removeEventListener("click", handleLeftClick);
    };
  }, []);

  return (
    <div>
      {showMenu && (
        <RightClickMenu x={menuX} y={menuY} onItemClick={handleItemClick} />
      )}

      {selectedAction && <h1>Selected Action: {selectedAction}</h1>}
    </div>
  );
};

export default App;
