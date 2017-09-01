using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_objectmodel_ldtoken_ldtoken_
    {
        [OuterLoop]
        [Fact]
        public void _Old_objectmodel_ldtoken_ldtoken_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\objectmodel\\ldtoken\\ldtoken.cmd");
        }
    }
}
