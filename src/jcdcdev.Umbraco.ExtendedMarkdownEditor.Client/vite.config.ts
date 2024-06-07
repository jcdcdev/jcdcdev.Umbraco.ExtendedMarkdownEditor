import { defineConfig } from "vite";

export default defineConfig({
  build: {
    lib: {
      entry: "src/index.ts",
      formats: ["es"],
    },
    outDir: "../jcdcdev.Umbraco.ExtendedMarkdownEditor/wwwroot/App_Plugins/jcdcdev.Umbraco.ExtendedMarkdownEditor/dist/",
    sourcemap: true,
    rollupOptions: {
      external: [/^@umbraco/],
    },
  },
});
