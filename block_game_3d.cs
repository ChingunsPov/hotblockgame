@import url("https://fonts.googleapis.com/css?family=Comfortaa");
html,
body {
  margin: 0;
  overflow: hidden;
  height: 100%;
  width: 100%;
  position: relative;
  font-family: "Comfortaa", cursive;
}

#container {
  width: 100%;
  height: 100%;
}
#container #score {
  position: absolute;
  top: 20px;
  width: 100%;
  text-align: center;
  font-size: 10vh;
  transition: transform 0.5s ease;
  color: #333344;
  transform: translatey(-200px) scale(1);
}
#container #game {
  position: absolute;
  top: 0;
  right: 0;
  bottom: 0;
  left: 0;
}
#container .game-over {
  position: absolute;
  top: 0;
  left: 0;
  width: 100%;
  height: 85%;
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: center;
}
#container .game-over * {
  transition: opacity 0.5s ease, transform 0.5s ease;
  opacity: 0;
  transform: translatey(-50px);
  color: #333344;
}
#container .game-over h2 {
  margin: 0;
  padding: 0;
  font-size: 40px;
}
#container .game-ready {
  position: absolute;
  top: 0;
  left: 0;
  width: 100%;
  height: 100%;
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: space-around;
}
#container .game-ready #start-button {
  transition: opacity 0.5s ease, transform 0.5s ease;
  opacity: 0;
  transform: translatey(-50px);
  border: 3px solid #333344;
  padding: 10px 20px;
  background-color: transparent;
  color: #333344;
  font-size: 30px;
}
#container #instructions {
  position: absolute;
  width: 100%;
  top: 16vh;
  left: 0;
  text-align: center;
  transition: opacity 0.5s ease, transform 0.5s ease;
  opacity: 0;
}
#container #instructions.hide {
  opacity: 0 !important;
}
#container.playing #score, #container.resetting #score {
  transform: translatey(0px) scale(1);
}
#container.playing #instructions {
  opacity: 1;
}
#container.ready .game-ready #start-button {
  opacity: 1;
  transform: translatey(0);
}
#container.ended #score {
  transform: translatey(6vh) scale(1.5);
}
#container.ended .game-over * {
  opacity: 1;
  transform: translatey(0);
}
#container.ended .game-over p {
  transition-delay: 0.3s;
}
