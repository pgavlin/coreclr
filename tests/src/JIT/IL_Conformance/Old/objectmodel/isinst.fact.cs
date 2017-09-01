using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_objectmodel_isinst_isinst_
    {
        [OuterLoop]
        [Fact]
        public void _Old_objectmodel_isinst_isinst_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\objectmodel\\isinst\\isinst.cmd");
        }
    }
}
