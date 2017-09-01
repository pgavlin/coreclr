using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _explicit_funcptr_seq_funcptr_gc_d_seq_funcptr_gc_d_
    {
        [OuterLoop]
        [Fact]
        public void _explicit_funcptr_seq_funcptr_gc_d_seq_funcptr_gc_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\funcptr\\seq_funcptr_gc_d\\seq_funcptr_gc_d.cmd");
        }
    }
}
