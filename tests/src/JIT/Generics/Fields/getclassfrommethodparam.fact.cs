using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    public class _Fields_getclassfrommethodparam_getclassfrommethodparam_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _Fields_getclassfrommethodparam_getclassfrommethodparam_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Generics\\Fields\\getclassfrommethodparam\\getclassfrommethodparam.cmd");
        }
    }
}
