CALL node_modules/.bin/pbjs.cmd --no-create --no-verify --no-convert --no-delimited --force-long --target static --out src/gen/internal-client-protocol.js ../../../protocol/plexus.interop.proto
CALL node_modules/.bin/pbts.cmd --out src/gen/internal-client-protocol.d.ts src/gen/internal-client-protocol.js
CALL node_modules/.bin/pbjs.cmd --no-create --no-verify --no-convert --no-delimited --force-long --target static --out src/gen/internal-transport-protocol.js ../../../protocol/plexus.interop.transport.proto
CALL node_modules/.bin/pbts.cmd --out src/gen/internal-transport-protocol.d.ts src/gen/internal-transport-protocol.js