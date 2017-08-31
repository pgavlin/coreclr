using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_misc__relbox__relbox_
    {
        [OuterLoop]
        [Fact]
        public void _int64_misc__relbox__relbox_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\misc\\_relbox\\_relbox.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
