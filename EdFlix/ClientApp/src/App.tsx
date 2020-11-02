import * as React from "react";
import Layout from "./components/Layout";
import { Movies } from "./components/Movies";
import { Sidebar } from "./components/Sidebar";

import "./custom.css";

export default () => (
  <Layout>
    <h1>Movie App</h1>
    <Sidebar />
    <Movies />
  </Layout>
);
