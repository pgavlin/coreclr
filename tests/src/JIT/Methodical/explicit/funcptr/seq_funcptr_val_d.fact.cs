using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_funcptr_seq_funcptr_val_d_seq_funcptr_val_d_
    {
        [OuterLoop]
        [Fact]
        public void _explicit_funcptr_seq_funcptr_val_d_seq_funcptr_val_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\funcptr\\seq_funcptr_val_d\\seq_funcptr_val_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
