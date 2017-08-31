using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _regress_ndpw_14888_objectusedonlyinhandler_objectusedonlyinhandler_
    {
        [OuterLoop]
        [Fact]
        public void _regress_ndpw_14888_objectusedonlyinhandler_objectusedonlyinhandler_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\regress\\ndpw\\14888\\objectusedonlyinhandler\\objectusedonlyinhandler.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
