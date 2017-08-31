using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Boxing_morph_sin3double_sin3double_
    {
        [Fact]
        public void _Boxing_morph_sin3double_sin3double_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Boxing\\morph\\sin3double\\sin3double.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
