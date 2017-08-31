using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_misc__speed_relbox__speed_relbox_
    {
        [OuterLoop]
        [Fact]
        public void _int64_misc__speed_relbox__speed_relbox_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\misc\\_speed_relbox\\_speed_relbox.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
