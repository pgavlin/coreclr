using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _threadpool_bindhandle_bindhandleinvalid3_bindhandleinvalid3_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _threadpool_bindhandle_bindhandleinvalid3_bindhandleinvalid3_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\threadpool\\bindhandle\\bindhandleinvalid3\\bindhandleinvalid3.cmd");
        }
    }
}
