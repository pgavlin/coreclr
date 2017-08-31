using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_funcptr_expl_funcptr_val_d_expl_funcptr_val_d_
    {
        [OuterLoop]
        [Fact]
        public void _explicit_funcptr_expl_funcptr_val_d_expl_funcptr_val_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\funcptr\\expl_funcptr_val_d\\expl_funcptr_val_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
