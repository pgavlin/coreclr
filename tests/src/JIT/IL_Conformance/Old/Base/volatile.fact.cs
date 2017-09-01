using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Base_volatile_volatile_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Base_volatile_volatile_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\volatile\\volatile.cmd");
        }
    }
}
