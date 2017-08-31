using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_funcptr_expl_funcptr_gc_r_expl_funcptr_gc_r_
    {
        [OuterLoop]
        [Fact]
        public void _explicit_funcptr_expl_funcptr_gc_r_expl_funcptr_gc_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\funcptr\\expl_funcptr_gc_r\\expl_funcptr_gc_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
