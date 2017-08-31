using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_implicit__speed_relobj__speed_relobj_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_implicit__speed_relobj__speed_relobj_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\implicit\\_speed_relobj\\_speed_relobj.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
