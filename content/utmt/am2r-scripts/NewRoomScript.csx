// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this file,
// You can obtain one at https://mozilla.org/MPL/2.0/.


var room = new UndertaleRoom();
room.Width = 320;
room.Height = 240;
room.Speed = 60;
room.Name = Data.Strings.MakeString("newroom" + Data.Rooms.Count);
room.Backgrounds[0].BackgroundDefinition = Data.Backgrounds.ByName("bgScreenGuide");
room.Backgrounds[0].Enabled = true;
var view = room.Views[0];
view.ViewX = view.ViewY = 0;
view.ViewWidth = 320;
view.ViewHeight = 240;

view.PortX = view.PortY = 0;
view.PortWidth = 320;
view.PortHeight = 240;

view.BorderX = view.BorderY = 160;
view.SpeedX = view.SpeedY = -1;
view.ObjectId = Data.GameObjects.ByName("oCamera");

Data.Rooms.Add(room);
