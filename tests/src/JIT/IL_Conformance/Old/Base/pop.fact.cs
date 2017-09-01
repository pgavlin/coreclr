using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Base_pop_pop_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Base_pop_pop_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\pop\\pop.cmd");
        }
    }
}
