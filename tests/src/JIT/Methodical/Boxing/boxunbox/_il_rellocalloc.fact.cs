using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _Boxing_boxunbox__il_rellocalloc__il_rellocalloc_
    {
        [OuterLoop]
        [Fact]
        public void _Boxing_boxunbox__il_rellocalloc__il_rellocalloc_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\Boxing\\boxunbox\\_il_rellocalloc\\_il_rellocalloc.cmd");
        }
    }
}
