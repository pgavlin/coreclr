using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _acceptance_Boxing_boxing001_boxing001_
    {
        [OuterLoop]
        [Fact]
        public void _acceptance_Boxing_boxing001_boxing001_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\acceptance\\Boxing\\boxing001\\boxing001.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
