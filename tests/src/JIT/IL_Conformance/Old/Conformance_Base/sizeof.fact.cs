using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_sizeof_sizeof_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_sizeof_sizeof_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\sizeof\\sizeof.cmd");
        }
    }
}
