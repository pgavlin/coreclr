using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _explicit_funcptr_expl_funcptr_gc_d_expl_funcptr_gc_d_
    {
        [OuterLoop]
        [Fact]
        public void _explicit_funcptr_expl_funcptr_gc_d_expl_funcptr_gc_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\funcptr\\expl_funcptr_gc_d\\expl_funcptr_gc_d.cmd");
        }
    }
}
