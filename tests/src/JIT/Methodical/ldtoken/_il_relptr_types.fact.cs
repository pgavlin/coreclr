using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _ldtoken__il_relptr_types__il_relptr_types_
    {
        [OuterLoop]
        [Fact]
        public void _ldtoken__il_relptr_types__il_relptr_types_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\ldtoken\\_il_relptr_types\\_il_relptr_types.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
