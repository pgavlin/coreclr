using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _explicit_funcptr_expl_funcptr_val_r_expl_funcptr_val_r_
    {
        [OuterLoop]
        [Fact]
        public void _explicit_funcptr_expl_funcptr_val_r_expl_funcptr_val_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\funcptr\\expl_funcptr_val_r\\expl_funcptr_val_r.cmd");
        }
    }
}
