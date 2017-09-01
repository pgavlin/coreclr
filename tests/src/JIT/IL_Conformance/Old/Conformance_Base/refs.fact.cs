using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_refs_refs_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_refs_refs_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\refs\\refs.cmd");
        }
    }
}
