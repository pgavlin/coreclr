using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _jitinterface_bug603649_bug603649_
    {
        [OuterLoop]
        [Fact]
        public void _jitinterface_bug603649_bug603649_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\jitinterface\\bug603649\\bug603649.cmd");
        }
    }
}
