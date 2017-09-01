using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_objectmodel_callstatic_callstatic_
    {
        [OuterLoop]
        [Fact]
        public void _Old_objectmodel_callstatic_callstatic_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\objectmodel\\callstatic\\callstatic.cmd");
        }
    }
}
