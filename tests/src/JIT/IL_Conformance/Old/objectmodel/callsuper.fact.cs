using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_objectmodel_callsuper_callsuper_
    {
        [OuterLoop]
        [Fact]
        public void _Old_objectmodel_callsuper_callsuper_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\objectmodel\\callsuper\\callsuper.cmd");
        }
    }
}
