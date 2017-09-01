using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_objectmodel_callintf_callintf_
    {
        [OuterLoop]
        [Fact]
        public void _Old_objectmodel_callintf_callintf_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\objectmodel\\callintf\\callintf.cmd");
        }
    }
}
