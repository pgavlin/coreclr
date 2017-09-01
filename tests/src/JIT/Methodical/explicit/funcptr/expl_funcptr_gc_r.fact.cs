using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _explicit_funcptr_expl_funcptr_gc_r_expl_funcptr_gc_r_
    {
        [OuterLoop]
        [Fact]
        public void _explicit_funcptr_expl_funcptr_gc_r_expl_funcptr_gc_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\funcptr\\expl_funcptr_gc_r\\expl_funcptr_gc_r.cmd");
        }
    }
}
