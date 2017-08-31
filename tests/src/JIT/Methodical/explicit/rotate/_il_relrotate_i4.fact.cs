using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_rotate__il_relrotate_i4__il_relrotate_i4_
    {
        [OuterLoop]
        [Fact]
        public void _explicit_rotate__il_relrotate_i4__il_relrotate_i4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\rotate\\_il_relrotate_i4\\_il_relrotate_i4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
