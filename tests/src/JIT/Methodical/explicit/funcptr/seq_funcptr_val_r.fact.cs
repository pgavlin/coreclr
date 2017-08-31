using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_funcptr_seq_funcptr_val_r_seq_funcptr_val_r_
    {
        [OuterLoop]
        [Fact]
        public void _explicit_funcptr_seq_funcptr_val_r_seq_funcptr_val_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\funcptr\\seq_funcptr_val_r\\seq_funcptr_val_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
