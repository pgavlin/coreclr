using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_deep__reldeep__reldeep_
    {
        [Fact]
        public void _Invoke_deep__reldeep__reldeep_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\deep\\_reldeep\\_reldeep.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
