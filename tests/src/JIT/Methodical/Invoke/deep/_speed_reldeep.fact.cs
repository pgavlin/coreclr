using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_deep__speed_reldeep__speed_reldeep_
    {
        [Fact]
        public void _Invoke_deep__speed_reldeep__speed_reldeep_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\deep\\_speed_reldeep\\_speed_reldeep.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
