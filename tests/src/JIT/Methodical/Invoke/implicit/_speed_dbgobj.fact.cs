using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_implicit__speed_dbgobj__speed_dbgobj_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_implicit__speed_dbgobj__speed_dbgobj_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\implicit\\_speed_dbgobj\\_speed_dbgobj.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
