using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_objectmodel_ldlen_ldlen_
    {
        [OuterLoop]
        [Fact]
        public void _Old_objectmodel_ldlen_ldlen_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\objectmodel\\ldlen\\ldlen.cmd");
        }
    }
}
