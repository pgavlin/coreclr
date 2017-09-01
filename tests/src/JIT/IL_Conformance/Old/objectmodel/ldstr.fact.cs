using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_objectmodel_ldstr_ldstr_
    {
        [OuterLoop]
        [Fact]
        public void _Old_objectmodel_ldstr_ldstr_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\objectmodel\\ldstr\\ldstr.cmd");
        }
    }
}
